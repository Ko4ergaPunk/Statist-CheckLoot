using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.IO;
using YamlDotNet.RepresentationModel;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace statist
{
    public partial class MainProgram : Form
    {
        public static Category SelectedCategory => _selectedCategory;
        public static Room SelectedRoom => _selectedRoom;
        public static Entity SelectedEntity => _selectedEntity;

        private static Category _selectedCategory;
        private static Room _selectedRoom;
        private static Entity _selectedEntity;

        private ListBox[] _entitiesLists;
        private List<Category> _categories;

        private Dictionary<int, Color> _itemColors = new();

        public MainProgram()
        {
            InitializeComponent();
            InitializeRooms();
            InitializeEntitiesLists();
            InitializeColors();

            this.StartPosition = FormStartPosition.CenterScreen;

            _categories = new List<Category>();

            Trace.Listeners.Add(new DefaultTraceListener());
            Trace.AutoFlush = true;
        }

        #region [ Classes ]

        public class Category
        {
            public string Name;
            public override string ToString() => Name;

            public List<Room> Rooms = new List<Room>();
        }

        public class Room
        {
            public string Name;
            public override string ToString() => Name;

            public int Priority = 1;

            public List<Entity> RequiredEntities = new List<Entity>();
            public List<Entity> RecommendedEntities = new List<Entity>();
            public List<Entity> OptionalEntities = new List<Entity>();
        }

        public class Entity
        {
            public string Name;
            public override string ToString() => $"{Name} [{Max}|{Min}]";

            public int Max = 1;
            public int Min = 1;

            public bool IncludeEntities = false;
            public List<string> EntitiesIncluded = new List<string>();
        }

        #endregion

        #region [ Add ]

        private void AddButton_Click(object sender, EventArgs e)
        {
            using (var form = new InputForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    string userText = form.ResultText;
                    Category newCategory = new Category { Name = userText };
                    ListCategories.Items.Add(newCategory);
                    _categories.Add(newCategory);
                }
            }
        }

        private void AddRoomButton_Click(object sender, EventArgs e)
        {
            if (ListCategories.SelectedIndex != -1)
            {
                using (var form = new InputForm())
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        string userText = form.ResultText;
                        _selectedCategory.Rooms.Add(new Room { Name = userText });
                        RefreshRooms();
                    }
                }
            }
        }

        private void AddRequired_Click(object sender, EventArgs e)
        {
            if (ListRooms.SelectedIndex != -1)
                AddAndRefreshEntity(_selectedRoom.RequiredEntities, ListRequired, 0);
        }

        private void AddRecommended_Click(object sender, EventArgs e)
        {
            if (ListRooms.SelectedIndex != -1)
                AddAndRefreshEntity(_selectedRoom.RecommendedEntities, ListRecommend, 1);
        }

        private void AddOptional_Click(object sender, EventArgs e)
        {
            if (ListRooms.SelectedIndex != -1)
                AddAndRefreshEntity(_selectedRoom.OptionalEntities, ListOptional, 2);
        }

        private void AddAndRefreshEntity(List<Entity> typeOfEntities, ListBox listBox, int index)
        {
            using (var form = new InputForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    string userText = form.ResultText;
                    typeOfEntities.Add(new Entity { Name = userText });
                    RefreshEntitiesList(listBox, index);
                }
            }
        }

        #endregion

        #region [ Remove ]

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (ListCategories.SelectedIndex != -1)
            {
                _categories.RemoveAt(ListCategories.SelectedIndex);
                RefreshCategories();
            }
        }

        private void RemoveRoomButton_Click(object sender, EventArgs e)
        {
            if (ListRooms.SelectedIndex != -1)
            {
                _selectedCategory.Rooms.RemoveAt(ListRooms.SelectedIndex);
                RefreshRooms();
            }
        }

        private void RemoveRequired_Click(object sender, EventArgs e)
        {
            if (ListRequired.SelectedIndex != -1)
                RemoveAndRefreshEntity(_selectedRoom.RequiredEntities, ListRequired, 0);
        }

        private void RemoveRecommended_Click(object sender, EventArgs e)
        {
            if (ListRecommend.SelectedIndex != -1)
                RemoveAndRefreshEntity(_selectedRoom.RecommendedEntities, ListRecommend, 1);
        }

        private void RemoveOptional_Click(object sender, EventArgs e)
        {
            if (ListOptional.SelectedIndex != -1)
                RemoveAndRefreshEntity(_selectedRoom.OptionalEntities, ListOptional, 2);
        }

        private void RemoveAndRefreshEntity(List<Entity> typeOfEntitie, ListBox listBox, int index)
        {
            typeOfEntitie.RemoveAt(listBox.SelectedIndex);
            RefreshEntitiesList(listBox, index);
        }

        #endregion

        #region [ Double click ]

        private void ListRooms_DoubleClick(object sender, EventArgs e)
        {
            if (ListRooms.SelectedIndex != -1)
            {
                using (var form = new RoomSettings())
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        Room selectedRoom = ListRooms.SelectedItem as Room;

                        selectedRoom.Priority = form.SelectedPriority;
                        selectedRoom.Name = form.RoomName;

                        RefreshRooms();
                    }
                }
            }
        }

        private void ListRequired_DoubleClick(object sender, EventArgs e)
        {
            DoubleClickListEntities(ListRequired, 0);
        }

        private void ListRecommended_DoubleClick(object sender, EventArgs e)
        {
            DoubleClickListEntities(ListRecommend, 1);
        }

        private void ListOptional_DoubleClick(object sender, EventArgs e)
        {
            DoubleClickListEntities(ListOptional, 2);
        }

        private void DoubleClickListEntities(ListBox listBox, int entitiesListIndex)
        {
            if (listBox.SelectedIndex != -1)
            {
                using (var form = new EntityProperties())
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        _selectedEntity.Name = form.EntityName;
                        _selectedEntity.IncludeEntities = form.IncludeEntities;
                        _selectedEntity.Max = form.MaxValue;
                        _selectedEntity.Min = form.MinValue;

                        if (SelectedEntity.IncludeEntities)
                        {
                            _selectedEntity.EntitiesIncluded = new List<string>(form.EntitiesIncluded);
                            _selectedEntity.EntitiesIncluded.Sort();
                        }
                        else
                            _selectedEntity.EntitiesIncluded.Clear();

                        RefreshEntitiesList(listBox, entitiesListIndex);
                    }
                }
            }
        }

        #endregion

        #region [ Selected ]

        private void ListCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListCategories.SelectedItem is Category selected)
            {
                _selectedCategory = selected;
                _selectedRoom = null;
                RefreshRooms();
                RefreshAllEntitiesLists();
            }
        }

        private void ListRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListRooms.SelectedItem is Room selected)
            {
                _selectedRoom = selected;
                RefreshAllEntitiesLists();
            }
        }

        private void ListRequired_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectEntity(ListRequired);
        }

        private void ListRecommend_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectEntity(ListRecommend);
        }

        private void ListOptional_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectEntity(ListOptional);
        }

        private void SelectEntity(ListBox list)
        {
            if (list.SelectedItem is Entity selected)
            {
                _selectedEntity = selected;
                Trace.WriteLine(_selectedEntity);
            }
        }

        #endregion

        #region [ Refresh ]

        private void RefreshCategories()
        {
            ListCategories.Items.Clear();
            ListCategories.Items.AddRange(_categories.ToArray());
        }

        private void RefreshRooms()
        {
            ListRooms.Items.Clear();
            if (_selectedCategory == null) return;

            _selectedCategory.Rooms.Sort((x, y) => string.Compare(x.Name, y.Name));
            _selectedCategory.Rooms = _selectedCategory.Rooms.OrderBy(room => room.Priority).ToList();

            ListRooms.Items.AddRange(_selectedCategory.Rooms.ToArray());

            for (int i = 0; i < _selectedCategory.Rooms.Count; i++)
            {
                Color color;
                switch (_selectedCategory.Rooms[i].Priority)
                {
                    case 1:
                        color = ColorTranslator.FromHtml("#e94c3d");
                        break;
                    case 2:
                        color = ColorTranslator.FromHtml("#f1c30f");
                        break;
                    default:
                        color = ColorTranslator.FromHtml("#2dcb6f");
                        break;
                }

                SetItemColor(i, color);
            }
        }

        private void RefreshAllEntitiesLists()
        {
            RefreshEntitiesList(ListRequired, 0);
            RefreshEntitiesList(ListRecommend, 1);
            RefreshEntitiesList(ListOptional, 2);
        }

        private void RefreshEntitiesList(ListBox list, int entitiesListIndex)
        {
            list.Items.Clear();
            if (_selectedRoom == null) return;

            switch (entitiesListIndex)
            {
                case 0:
                    _selectedRoom.RequiredEntities.Sort((x, y) => string.Compare(x.Name, y.Name));
                    for (int i = 0; i < _selectedRoom.RequiredEntities.Count; i++)
                    {
                        var item = _selectedRoom.RequiredEntities[i];
                        AddItemToList(list, item);
                    }
                    break;
                case 1:
                    _selectedRoom.RecommendedEntities.Sort((x, y) => string.Compare(x.Name, y.Name));
                    for (int i = 0; i < _selectedRoom.RecommendedEntities.Count; i++)
                    {
                        var item = _selectedRoom.RecommendedEntities[i];
                        AddItemToList(list, item);
                    }
                    break;
                default:
                    _selectedRoom.OptionalEntities.Sort((x, y) => string.Compare(x.Name, y.Name));
                    for (int i = 0; i < _selectedRoom.OptionalEntities.Count; i++)
                    {
                        var item = _selectedRoom.OptionalEntities[i];
                        AddItemToList(list, item);
                    }
                    break;
            }
        }

        private void AddItemToList(ListBox list, Entity item)
        {
            list.Items.Add(item);
        }

        #endregion

        #region [ Text formating ]

        private void ListRooms_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            string text = ListRooms.Items[e.Index].ToString();
            Color color = _itemColors.ContainsKey(e.Index) ? _itemColors[e.Index] : e.ForeColor;
            e.DrawBackground();

            Room room = ListRooms.Items[e.Index] as Room;

            using (SolidBrush brush = new SolidBrush(color))
            {
                e.Graphics.DrawString($"[{room.Priority}] {text}", e.Font, brush, e.Bounds.X, e.Bounds.Y);
            }

            e.DrawFocusRectangle();
        }

        private void SetItemColor(int index, Color color)
        {
            _itemColors[index] = color;
            ListRooms.Invalidate(ListRooms.GetItemRectangle(index));
        }

        #endregion

        #region [ Visual ]

        private void InitializeEntitiesLists()
        {
            _entitiesLists = new ListBox[3];

            _entitiesLists[0] = ListRequired;
            _entitiesLists[1] = ListRecommend;
            _entitiesLists[2] = ListOptional;

            _entitiesLists[0].BackColor = ColorTranslator.FromHtml("#ffe3e3");
            _entitiesLists[1].BackColor = ColorTranslator.FromHtml("#fff9e3");
            _entitiesLists[2].BackColor = ColorTranslator.FromHtml("#e3ffe6");
        }

        private void InitializeRooms()
        {
            ListRooms.DrawMode = DrawMode.OwnerDrawFixed;
            ListRooms.DrawItem += ListRooms_DrawItem;
            ListRooms.HorizontalScrollbar = true;
            ListRooms.ItemHeight = 21;
        }

        private void InitializeColors()
        {
            this.BackColor = ColorTranslator.FromHtml("#2b2b2b");

            AddButton.FlatAppearance.BorderSize = 0;
            AddRoomButton.FlatAppearance.BorderSize = 0;
            AddRequired.FlatAppearance.BorderSize = 0;
            AddRecommended.FlatAppearance.BorderSize = 0;
            AddOptional.FlatAppearance.BorderSize = 0;

            RemoveButton.FlatAppearance.BorderSize = 0;
            RemoveRoomButton.FlatAppearance.BorderSize = 0;
            RemoveRequired.FlatAppearance.BorderSize = 0;
            RemoveRecommended.FlatAppearance.BorderSize = 0;
            RemoveOptional.FlatAppearance.BorderSize = 0;

            SaveButton.FlatAppearance.BorderSize = 0;
            LoadButton.FlatAppearance.BorderSize = 0;
            ResetButton.FlatAppearance.BorderSize = 0;

            label1.BackColor = ColorTranslator.FromHtml("#2b2b2b");
            label2.BackColor = ColorTranslator.FromHtml("#2b2b2b");
            label3.BackColor = ColorTranslator.FromHtml("#2b2b2b");

            RemoveButton.BackColor = ColorTranslator.FromHtml("#006bbd");
            RemoveRoomButton.BackColor = ColorTranslator.FromHtml("#006bbd");
            RemoveRequired.BackColor = ColorTranslator.FromHtml("#006bbd");
            RemoveRecommended.BackColor = ColorTranslator.FromHtml("#006bbd");
            RemoveOptional.BackColor = ColorTranslator.FromHtml("#006bbd");

            ListCategories.BackColor = ColorTranslator.FromHtml("#333333");
            ListRooms.BackColor = ColorTranslator.FromHtml("#333333");
            ListRequired.BackColor = ColorTranslator.FromHtml("#3d3333");
            ListRecommend.BackColor = ColorTranslator.FromHtml("#383833");
            ListOptional.BackColor = ColorTranslator.FromHtml("#333d33");
        }

        #endregion

        #region [ YAML exporter ]

        public class YamlExporter
        {
            public static string ExportCategories(List<Category> categories)
            {
                var sb = new StringBuilder();
                foreach (var category in categories)
                {
                    sb.AppendLine($"{category.Name}:");
                    sb.AppendLine($"  color: 0x52B4E9"); // если есть цвет
                    sb.AppendLine("  rooms:");

                    // Группируем комнаты по Priority
                    var roomsByPriority = category.Rooms.GroupBy(r => r.Priority).OrderBy(g => g.Key);
                    foreach (var group in roomsByPriority)
                    {
                        sb.AppendLine($"    {group.Key}:");
                        foreach (var room in group)
                        {
                            sb.AppendLine($"      {room.Name}:");
                            sb.AppendLine("        items:");

                            // Required = 1, Recommended = 2, Optional = 3
                            ExportEntitiesGroup(room.RequiredEntities, sb, 10, 1);
                            ExportEntitiesGroup(room.RecommendedEntities, sb, 10, 2);
                            ExportEntitiesGroup(room.OptionalEntities, sb, 10, 3);
                        }
                    }
                }
                return sb.ToString();
            }

            private static void ExportEntitiesGroup(List<Entity> entities, StringBuilder sb, int indent, int groupNumber)
            {
                if (entities == null || entities.Count == 0) return;

                string indentStr = new string(' ', indent);
                sb.AppendLine($"{indentStr}{groupNumber}:");
                string innerIndent = new string(' ', indent + 2);

                foreach (var entity in entities)
                {
                    string name = entity.IncludeEntities ? $"${entity.Name}" : entity.Name;
                    sb.AppendLine($"{innerIndent}{name}:");

                    if (entity.IncludeEntities && entity.EntitiesIncluded.Count > 0)
                    {
                        sb.AppendLine($"{innerIndent}  items:");
                        foreach (var subItem in entity.EntitiesIncluded)
                        {
                            sb.AppendLine($"{innerIndent}  - {subItem}");
                        }
                    }

                    sb.AppendLine($"{innerIndent}  min: {entity.Min}");
                    string maxStr = (entity.Max == 99) ? "null" : entity.Max.ToString();
                    sb.AppendLine($"{innerIndent}  max: {maxStr}");
                }
            }
        }

        // В обработчике кнопки
        private void SaveButton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "YAML files (*.yml)|*.yml|All files (*.*)|*.*";
                saveFileDialog.Title = "Сохранить категории";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string path = saveFileDialog.FileName;

                    string yaml = YamlExporter.ExportCategories(_categories);

                    System.IO.File.WriteAllText(path, yaml);
                    MessageBox.Show("Экспорт завершён!");
                }
            }
        }

        #endregion

        #region [ YAML importer ]

        public static class YamlImporter
        {
            public static List<Category> ImportCategories(string yamlContent)
            {
                var categories = new List<Category>();

                using (var reader = new StringReader(yamlContent))
                {
                    var yaml = new YamlStream();
                    yaml.Load(reader);

                    var root = (YamlMappingNode)yaml.Documents[0].RootNode;

                    foreach (var categoryNode in root.Children)
                    {
                        string categoryName = categoryNode.Key.ToString();
                        var categoryMapping = (YamlMappingNode)categoryNode.Value;

                        var category = new Category
                        {
                            Name = categoryName
                        };

                        if (categoryMapping.Children.ContainsKey("rooms"))
                        {
                            var roomsNode = (YamlMappingNode)categoryMapping.Children[new YamlScalarNode("rooms")];

                            foreach (var roomPriorityNode in roomsNode.Children)
                            {
                                int priority = int.Parse(roomPriorityNode.Key.ToString());
                                var roomMapping = (YamlMappingNode)roomPriorityNode.Value;

                                foreach (var roomNode in roomMapping.Children)
                                {
                                    var roomName = roomNode.Key.ToString();
                                    var room = new Room
                                    {
                                        Name = roomName,
                                        Priority = priority
                                    };

                                    var itemsNode = roomNode.Value is YamlMappingNode rNodeMapping && rNodeMapping.Children.ContainsKey(new YamlScalarNode("items"))
                                        ? rNodeMapping.Children[new YamlScalarNode("items")] as YamlMappingNode
                                        : null;

                                    if (itemsNode == null)
                                        continue;

                                    foreach (var itemIndexNode in itemsNode.Children)
                                    {
                                        var itemMapping = itemIndexNode.Value as YamlMappingNode;
                                        if (itemMapping == null)
                                            continue;

                                        foreach (var entityNode in itemMapping.Children)
                                        {
                                            // Игнорируем $ в начале имени при импорте
                                            string entityName = entityNode.Key.ToString();
                                            if (entityName.StartsWith("$"))
                                                entityName = entityName.Substring(1);

                                            var entityMapping = entityNode.Value as YamlMappingNode;

                                            var entity = new Entity
                                            {
                                                Name = entityName,
                                                IncludeEntities = entityMapping.Children.ContainsKey(new YamlScalarNode("items"))
                                            };

                                            if (entity.IncludeEntities)
                                            {
                                                var includedItemsNode = entityMapping.Children[new YamlScalarNode("items")] as YamlSequenceNode;
                                                if (includedItemsNode != null)
                                                {
                                                    foreach (var included in includedItemsNode)
                                                    {
                                                        entity.EntitiesIncluded.Add(included.ToString());
                                                    }
                                                }
                                            }

                                            if (entityMapping.Children.ContainsKey(new YamlScalarNode("value")))
                                            {
                                                var valueNode = (YamlMappingNode)entityMapping.Children[new YamlScalarNode("value")];
                                                entity.Min = ParseIntOrDefault(valueNode, "min");
                                                entity.Max = ParseIntOrDefault(valueNode, "max");
                                            }
                                            else
                                            {
                                                entity.Min = ParseIntOrDefault(entityMapping, "min");
                                                entity.Max = ParseIntOrDefault(entityMapping, "max");
                                            }

                                            int typeIndex = int.Parse(itemIndexNode.Key.ToString());
                                            switch (typeIndex)
                                            {
                                                case 1:
                                                    room.RequiredEntities.Add(entity);
                                                    break;
                                                case 2:
                                                    room.RecommendedEntities.Add(entity);
                                                    break;
                                                case 3:
                                                    room.OptionalEntities.Add(entity);
                                                    break;
                                            }
                                        }
                                    }

                                    category.Rooms.Add(room);
                                }
                            }
                        }

                        categories.Add(category);
                    }
                }

                return categories;
            }

            private static int ParseIntOrDefault(YamlMappingNode node, string key)
            {
                if (!node.Children.ContainsKey(new YamlScalarNode(key)))
                    return 99;

                var str = node.Children[new YamlScalarNode(key)].ToString();
                if (string.IsNullOrWhiteSpace(str) || str == "null")
                    return 99;

                if (int.TryParse(str, out int result))
                    return result;

                return 99;
            }
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "YAML files (*.yml)|*.yml|All files (*.*)|*.*";
                openFileDialog.Title = "Выберите YAML файл для импорта";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string path = openFileDialog.FileName;
                    string yamlContent = File.ReadAllText(path);

                    _categories = YamlImporter.ImportCategories(yamlContent);

                    RefreshCategories();

                    MessageBox.Show("Импорт завершён успешно!");
                }
            }
        }

        #endregion

        #region [ Reset ]

        private void ResetButton_Click(object sender, EventArgs e)
        {
            _categories.Clear();
            _selectedCategory = null;
            _selectedRoom = null;
            _selectedEntity = null;
            RefreshCategories();
            RefreshRooms();
            RefreshAllEntitiesLists();
        }

        #endregion
    }
}
