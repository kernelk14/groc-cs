/*
    * Ask user for actions
    * Try to set individual array per category
    * - Push items to each category
    * - Read items in each category
    * - Update item quantities
    * - Delete items in each category
*/

namespace Grocery {

    public class Rainbow {
        public static void Error(string contents) {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(contents);
            Console.ResetColor();
        }
        public static void Warning(string contents) {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(contents);
            Console.ResetColor();
        }
        public static void Success(string contents) {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(contents);
            Console.ResetColor();
        }
    }

    class Program {
        static Dictionary<string, int> food = new Dictionary<string, int>();
        static Dictionary<string, int> drinks = new Dictionary<string, int>();
        static Dictionary<string, int> frozen = new Dictionary<string, int>();
        static Dictionary<string, int> fruits_and_veg = new Dictionary<string, int>();
        

        public static void Push(Dictionary<string, int> l, string name, int quan) {
            l.Add(name, quan);
        }
        public static void Update(Dictionary<string, int> l, string name, int quan) {
            l[name] = quan;
        }
        public static void Rem(Dictionary<string, int> l, string name) {
            l.Remove(name);
        }

        public static void AddCategory() {
            Console.WriteLine("Choose a category below:");
            Console.WriteLine("1. Fresh Foods");
            Console.WriteLine("2. Cold Drinks");
            Console.WriteLine("3. Frozen Goods");
            Console.WriteLine("4. Fruits and Vegetables");

            Console.ForegroundColor = ConsoleColor.Green;
            int choice = Inputs.GetInt("Choice: ");
            Console.ResetColor();

            if (choice == 1) { // FOOD
                if (food.Count <= 0) {
                    Console.WriteLine("No Items.");
                } else {
                    Console.WriteLine("Foods:");
                    int ctr = 1;
                    foreach(var (item, value) in food) {
                        Console.WriteLine($"{ctr}. {item} - {value}");
                        ctr += 1;
                    }
                                
                }
                string it = Inputs.GetString("Type the item you want to add: ");
                int quan = Inputs.GetInt($"Enter quantity for item `{it}`: ");
                Push(food, it, quan);
            } else if (choice == 2) {
                if (drinks.Count <= 0) {
                    Console.WriteLine("No Items.");
                } else {
                    Console.WriteLine("Drinks:");
                    int ctr = 1;
                    foreach(var (item, value) in drinks) {
                        Console.WriteLine($"{ctr}. {item} - {value}");
                        ctr += 1;
                    }
                    
                }
                string it = Inputs.GetString("Type the item you want to add: ");
                int quan = Inputs.GetInt($"Enter quantity for item `{it}`: ");
                Push(drinks, it, quan);
            } else if (choice == 3) {
                if (frozen.Count <= 0) {
                    Console.WriteLine("No Items.");
                } else {
                    Console.WriteLine("Frozen Goods:");
                    int ctr = 1;
                    foreach(var (item, value) in frozen) {
                        Console.WriteLine($"{ctr}. {item} - {value}");
                        ctr += 1;
                    } 
                }
                string it = Inputs.GetString("Type the item you want to add: ");
                int quan = Inputs.GetInt($"Enter quantity for item `{it}`: ");
                Push(frozen, it, quan);
            } else if (choice == 4) {
                if (fruits_and_veg.Count <= 0) {
                    Console.WriteLine("No Items.");
                } else {
                    Console.WriteLine("Fruits and Vegetables:");
                    int ctr = 1;
                    foreach(var (item, value) in fruits_and_veg) {
                        Console.WriteLine($"{ctr}. {item} - {value}");
                        ctr += 1;
                    }
                                    
                }
                string it = Inputs.GetString("Type the item you want to add: ");
                int quan = Inputs.GetInt($"Enter quantity for item `{it}`: ");
                Push(fruits_and_veg, it, quan);
            } else {
                Rainbow.Error("What are you doing?");
            } 
        }
    
         
        public static void UpdCategory() {
            Console.WriteLine("Choose a category below:");
            Console.WriteLine("1. Fresh Foods");
            Console.WriteLine("2. Cold Drinks");
            Console.WriteLine("3. Frozen Goods");
            Console.WriteLine("4. Fruits and Vegetables");

            Console.ForegroundColor = ConsoleColor.Green;
            int choice = Inputs.GetInt("Choice: ");
            Console.ResetColor();

            if (choice == 1) { // FOOD
                if (food.Count <= 0) {
                    Console.WriteLine("No Items.");
                } else {
                    Console.WriteLine("Foods:");
                    int ctr = 1;
                    foreach(var (item, value) in food) {
                        Console.WriteLine($"{ctr}. {item} - {value}");
                        ctr += 1;
                    }
                    int x = Inputs.GetInt("Update Item: ") - 1;
                    string n = food.ElementAt(x).Key;
                    /*string n = Inputs.GetString("Type the item you want to update: ");*/
                    if (food.ContainsKey(n)) {
                        int quan = Inputs.GetInt($"Enter new value for {n}: ");
                        Update(food, n, quan);
                    } else {
                        Rainbow.Error($"There is no such {n} inside Foods.");
                    }
                }
            } else if (choice == 2) { // FOOD
                if (drinks.Count <= 0) {
                    Console.WriteLine("No Items.");
                } else {
                    Console.WriteLine("Drinks:");
                    int ctr = 1;
                    foreach(var (item, value) in drinks) {
                        Console.WriteLine($"{ctr}. {item} - {value}");
                        ctr += 1;
                    }
                    /*string n = Inputs.GetString("Type the item you want to update: ");*/
                    int x = Inputs.GetInt("Update Item: ") - 1;
                    string n = drinks.ElementAt(x).Key;
                    if (drinks.ContainsKey(n)) {
                        int quan = Inputs.GetInt($"Enter new value for {n}: ");
                        Update(drinks, n, quan);
                    } else {
                        Rainbow.Error($"There is no such {n} inside Drinks.");
                    }
                }
            } else if (choice == 3) { // FOOD
                if (frozen.Count <= 0) {
                    Console.WriteLine("No Items.");
                } else {
                    Console.WriteLine("Frozen Goods:");
                    int ctr = 1;
                    foreach(var (item, value) in frozen) {
                        Console.WriteLine($"{ctr}. {item} - {value}");
                        ctr += 1;
                    }
                    /*string n = Inputs.GetString("Type the item you want to update: ");*/
                    int x = Inputs.GetInt("Update Item: ") - 1;
                    string n = frozen.ElementAt(x).Key;
                    if (frozen.ContainsKey(n)) {
                        int quan = Inputs.GetInt($"Enter new value for {n}: ");
                        Update(frozen, n, quan);
                    } else {
                        Rainbow.Error($"There is no such {n} inside Frozen Goods.");
                    }
                }
            } else if (choice == 4) { // FOOD
                if (fruits_and_veg.Count <= 0) {
                    Console.WriteLine("No Items.");
                } else {
                    Console.WriteLine("Fruits and Vegetables:");
                    int ctr = 1;
                    foreach(var (item, value) in fruits_and_veg) {
                        Console.WriteLine($"{ctr}. {item} - {value}");
                        ctr += 1;
                    }
                    /*string n = Inputs.GetString("Type the item you want to update: ");*/
                    int x = Inputs.GetInt("Update Item: ") - 1;
                    string n = fruits_and_veg.ElementAt(x).Key;
                    if (fruits_and_veg.ContainsKey(n)) {
                        int quan = Inputs.GetInt($"Enter new value for {n}: ");
                        Update(food, n, quan);
                    } else {
                        Rainbow.Error($"There is no such {n} inside Fruits and Vegetables.");
                    }
                }
            } else {
                Rainbow.Error("Invalid Choice");
            }
        }
        
        public static void RemCategory() {
            Console.WriteLine("Choose a category below:");
            Console.WriteLine("1. Fresh Foods");
            Console.WriteLine("2. Cold Drinks");
            Console.WriteLine("3. Frozen Goods");
            Console.WriteLine("4. Fruits and Vegetables");

            Console.ForegroundColor = ConsoleColor.Green;
            int choice = Inputs.GetInt("Choice: ");
            Console.ResetColor();

            if (choice == 1) { // FOOD
                if (food.Count <= 0) {
                    Console.WriteLine("No Items.");
                } else {
                    Console.WriteLine("Foods:");
                    int ctr = 1;
                    foreach(var (item, value) in food) {
                        Console.WriteLine($"{ctr}. {item} - {value}");
                        ctr += 1;
                    }
                    int x = Inputs.GetInt("Remove Item: ") - 1;
                    string n = food.ElementAt(x).Key;
                    /*string n = Inputs.GetString("Type the item you want to update: ");*/
                    if (food.ContainsKey(n)) {
                        Rem(food, n);
                    } else {
                        Rainbow.Error($"There is no such {n} inside Foods.");
                    }
                }
            } else if (choice == 2) {
                if (drinks.Count <= 0) {
                    Console.WriteLine("No Items.");
                } else {
                    Console.WriteLine("Drinks:");
                    int ctr = 1;
                    foreach(var (item, value) in drinks) {
                        Console.WriteLine($"{ctr}. {item} - {value}");
                        ctr += 1;
                    }
                    int x = Inputs.GetInt("Remove Item: ") - 1;
                    string n = drinks.ElementAt(x).Key;
                    /*string n = Inputs.GetString("Type the item you want to update: ");*/
                    if (drinks.ContainsKey(n)) {
                        Rem(drinks, n);
                    } else {
                        Rainbow.Error($"There is no such {n} inside Drinks.");
                    }
                }
            } else if (choice == 3) {
                if (frozen.Count <= 0) {
                    Console.WriteLine("No Items.");
                } else {
                    Console.WriteLine("Frozen Goods:");
                    int ctr = 1;
                    foreach(var (item, value) in frozen) {
                        Console.WriteLine($"{ctr}. {item} - {value}");
                        ctr += 1;
                    }
                    int x = Inputs.GetInt("Remove Item: ") - 1;
                    string n = frozen.ElementAt(x).Key;
                    /*string n = Inputs.GetString("Type the item you want to update: ");*/
                    if (frozen.ContainsKey(n)) {
                        Rem(frozen, n);
                    } else {
                        Rainbow.Error($"There is no such {n} inside Frozen Goods.");
                    }
                }
            } else if (choice == 4) {
                if (fruits_and_veg.Count <= 0) {
                    Console.WriteLine("No Items.");
                } else {
                    Console.WriteLine("Fruits and Vegetables:");
                    int ctr = 1;
                    foreach(var (item, value) in fruits_and_veg) {
                        Console.WriteLine($"{ctr}. {item} - {value}");
                        ctr += 1;
                    }
                    int x = Inputs.GetInt("Remove Item: ") - 1;
                    string n = fruits_and_veg.ElementAt(x).Key;
                    /*string n = Inputs.GetString("Type the item you want to update: ");*/
                    if (fruits_and_veg.ContainsKey(n)) {
                        Rem(drinks, n);
                    } else {
                        Rainbow.Error($"There is no such {n} inside Fruits and Vegetables.");
                    }
                }
            }
        }
        
        public static void ViewCategory() {
            Console.WriteLine("Choose a category below:");
            Console.WriteLine("1. Fresh Foods");
            Console.WriteLine("2. Cold Drinks");
            Console.WriteLine("3. Frozen Goods");
            Console.WriteLine("4. Fruits and Vegetables");

            Console.ForegroundColor = ConsoleColor.Green;
            int choice = Inputs.GetInt("Choice: ");
            Console.ResetColor();

            if (choice == 1) { // FOOD
                if (food.Count <= 0) {
                    Console.WriteLine("No Items.");
                } else {
                    Console.WriteLine("Foods:");
                    int ctr = 1;
                    foreach(var (item, value) in food) {
                        Console.WriteLine($"{ctr}. {item} - {value}");
                        ctr += 1;
                    }
                }
            } else if (choice == 2) {
                if (drinks.Count <= 0) {
                    Console.WriteLine("No Items.");
                } else {
                    Console.WriteLine("Drinks:");
                    int ctr = 1;
                    foreach(var (item, value) in drinks) {
                        Console.WriteLine($"{ctr}. {item} - {value}");
                        ctr += 1;
                    }
                }
            } else if (choice == 3) { 
                if (frozen.Count <= 0) {
                    Console.WriteLine("No Items.");
                } else {
                    Console.WriteLine("Frozen Goods:");
                    int ctr = 1;
                    foreach(var (item, value) in frozen) {
                        Console.WriteLine($"{ctr}. {item} - {value}");
                        ctr += 1;
                    }
                }
            } else if (choice == 4) {
                if (fruits_and_veg.Count <= 0) {
                    Console.WriteLine("No Items.");
                } else {
                    Console.WriteLine("Fruits and Vegetables:");
                    int ctr = 1;
                    foreach(var (item, value) in fruits_and_veg) {
                        Console.WriteLine($"{ctr}. {item} - {value}");
                        ctr += 1;
                    }
                }
            } else {
                Rainbow.Error("Invalid Choice");
            }
        }

        public static void Main(string[] args) {
            Console.WriteLine("GROCERY STORE");
            
            bool running = true;

            while (running) {
                Console.WriteLine("Choose an action below:");
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Add Item");
                Console.WriteLine("2. Update Item");
                Console.WriteLine("3. Remove Item");
                Console.WriteLine("4. View Items");
                Console.ForegroundColor = ConsoleColor.Green;
                string choice = Inputs.GetString("Choice: ");
                Console.ResetColor();
                
                if (choice == "") {
                    continue;
                }

                int ch = Convert.ToInt32(choice);
                
                if (ch == 0) {
                    running = false;
                    break;
                }

                if (ch > 4) {
                    Rainbow.Error("Invalid choice.");
                }

                switch (ch) {
                    case 1:
                        AddCategory();
                        break;
                    case 2:
                        UpdCategory();
                        break;
                    case 3:
                        RemCategory();
                        break;
                    case 4:
                        ViewCategory();
                        break;
                }
            }
        }
    }
}
