// Проверить истинность утверждения (X ⋁ Y) = ¬X ⋀ ¬Y
 
 bool a = true;
 bool b = false;
// ! - отрицание - ¬ ; && - логическое и - ⋀  ; || - логическое или - ⋁
 
 if (( a || b) == !a && !b) Console.WriteLine("Утверждение истина");
 else Console.WriteLine("Утверждение ложно");
 
 bool x = true;
 bool y = true;

 if (( x || y) == !x && !y) Console.WriteLine("Утверждение истина");
 else Console.WriteLine("Утверждение ложно");
 
 bool c = false;
 bool d = false;

 if (( c || d) == !c && !d) Console.WriteLine("Утверждение истина");
 else Console.WriteLine("Утверждение ложно");

bool e = false;
bool f = false;

 if (( e || f) == !e && !f) Console.WriteLine("Утверждение истина");
 else Console.WriteLine("Утверждение ложно");