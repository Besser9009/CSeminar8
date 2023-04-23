Console.Clear();
void NewMethod(string whith = "1", string on = "3", string some = "2", int count = 2)
{
    if (count > 1) NewMethod(whith, some, on, count - 1);
    System.Console.WriteLine(count);
    System.Console.WriteLine($"{whith} >> {on}");
    if (count > 1) NewMethod(some, on, whith, count - 1);
}
NewMethod();