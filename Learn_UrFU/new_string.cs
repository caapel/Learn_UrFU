/*namespace Learn_UrFU
{
    public class MenuItem
    {
        public string Caption;
        public string HotKey;
        public MenuItem[] Items;
    }

    class Program
    {
        public static void Main()
        {
            var test = new MenuItem[2];
            test = GenerateMenu();
        }

        public static MenuItem[] GenerateMenu()
        {
            return new MenuItem[] {
                new MenuItem {
                    Caption = "File", HotKey = "F", Items = new MenuItem[] {
                        new MenuItem {Caption = "New", HotKey = "N"},
                        new MenuItem {Caption = "Save", HotKey = "S"}}},
                new MenuItem {
                    Caption = "Edit", HotKey = "E", Items = new MenuItem[] {
                        new MenuItem {Caption = "Copy", HotKey = "C"},
                        new MenuItem {Caption = "Paste", HotKey = "V"}}}
            };
        }
    }
}*/
