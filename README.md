Search Task Is Record Vs Struct Vs Class?

في Microsoft و لغة C# عندنا 3 أنواع مهمين جدًا لتخزين البيانات:

Class
Struct
Record

وكل واحد ليه استخدام مختلف.

هشرحهم بالترتيب من الأسهل والأكثر استخدامًا للمبتدئين



/////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////////////////////


أولًا: الـ Class

الـ Class هو أشهر نوع في C#، وده اللي هتستخدمه أغلب الوقت.

بيمثل “كائن” أو “Object” فيه بيانات + وظائف.

زي:

Student
Car
Book
User
مثال بسيط
class Student
{
    public string Name;
    public int Age;
}


استخدامه:

Student s1 = new Student();

s1.Name = "Ahmed";
s1.Age = 20;

Console.WriteLine(s1.Name);


فكرة الـ Class

الـ Class بيتخزن في:

Heap Memory

والمتغير بيخزن:

Reference (عنوان)

يعني المتغير مش ماسك البيانات نفسها.

مثال مهم جدًا
class Person
{
    public string Name;
}
Person p1 = new Person();
p1.Name = "Ali";

Person p2 = p1;

p2.Name = "Omar";

Console.WriteLine(p1.Name);

الناتج:

Omar
ليه حصل كده؟

لأن:

p1
p2

الاتنين بيشاوروا على نفس الـ Object في الذاكرة.

إمتى أستخدم Class؟

استخدمه لما:

البيانات كبيرة
محتاج inheritance
محتاج object يتغير
محتاج OOP كامل

وده الأكثر استخدامًا.



/////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////////////////////



ثانيًا: الـ Struct

الـ Struct شبه الـ Class جدًا…

لكن فيه فرق مهم جدًا:

Struct = Value Type
Class = Reference Type
يعني إيه Value Type؟

يعني المتغير بيخزن البيانات نفسها.

مش عنوان.

مثال
struct Point
{
    public int X;
    public int Y;
}

الاستخدام:

Point p1;

p1.X = 10;
p1.Y = 20;

Point p2 = p1;

p2.X = 50;

Console.WriteLine(p1.X);

الناتج:

10
ليه القيمة متغيرتش؟

لأن:

p2 خد نسخة مستقلة من البيانات

مش نفس المرجع.

الفرق الأساسي
Class
Person p2 = p1;

⬅ نفس الكائن

Struct
Point p2 = p1;

⬅ نسخة جديدة

إمتى أستخدم Struct؟

لما:

البيانات صغيرة
بسيطة
مش محتاج inheritance
عاوز أداء أسرع أحيانًا

أمثلة:

Point
Color
Date
Coordinates



/////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////////////////////



ثالثًا: الـ Record

الـ Record ظهر من C# 9.

وهو معمول مخصوص للبيانات.

يعني:

Data Models
DTO
API Response
Configurations
ليه Record مميز؟

لأنه:

يقارن بالقيم تلقائي
شكله مختصر
Immutable غالبًا
مثال
record Student(string Name, int Age);

الاستخدام:

Student s1 = new Student("Ali", 20);
Student s2 = new Student("Ali", 20);

Console.WriteLine(s1 == s2);

الناتج:

True
ركز هنا 👀

في الـ Class:

Console.WriteLine(c1 == c2);

غالبًا:

False

حتى لو البيانات متساوية.

لأنه بيقارن:

العنوان (Reference)

لكن الـ Record:
بيقارن:

البيانات نفسها

وده فرق ضخم جدًا.

مثال Class
class User
{
    public string Name;
}
User u1 = new User();
u1.Name = "Ali";

User u2 = new User();
u2.Name = "Ali";

Console.WriteLine(u1 == u2);

الناتج:

False
مثال Record
record User(string Name);
User u1 = new User("Ali");
User u2 = new User("Ali");

Console.WriteLine(u1 == u2);

الناتج:

True
Record مع التعديل

ميزة قوية جدًا:

record User(string Name, int Age);
User u1 = new User("Ali", 20);

User u2 = u1 with { Age = 30 };

Console.WriteLine(u1);
Console.WriteLine(u2);




/////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////////////////////





تستخدم إيه كمبتدئ؟
استخدم Class لو:
لسه مبتدئ
بتعمل مشاريع عادية
OOP
CRUD
APIs
استخدم Struct لو:
البيانات صغيرة جدًا
زي Point أو Position
استخدم Record لو:
شغال Data فقط
API
DTO
Configurations
ترتيب الحفظ للمبتدئين 🎯

احفظها كده:

Class  -> Objects كبيرة وقابلة للتغيير
Struct -> بيانات صغيرة وسريعة
Record -> بيانات للمقارنة والتخزين
مثال حقيقي من مشروع Travel Website

بما إن عندك مشروع حجوزات سفر:

Class
class Hotel
{
    public string Name;
    public double Price;
}

لأن الفندق Object كبير.

Struct
struct Location
{
    public double Lat;
    public double Lng;
}

إحداثيات صغيرة.

Record
record LoginResponse(string Token, string UserName);

مناسب جدًا للـ API Response.
