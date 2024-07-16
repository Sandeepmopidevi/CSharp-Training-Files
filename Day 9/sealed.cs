using System;
sealed public class S1{ //can't inherit
    sealed public int a=10; //can't be use access modifier
    sealed public virtual void show(){ //can't override
        int a=20;
        Console.WriteLine(a);
    }
}
class S2:S1{
    public override void show(){
        S2 s = new S2();
        Console.WriteLine(s.a);
        s.show();
}
}
/*
sealed.cs(9,7): error CS0509: 'S2': cannot derive from sealed type 'S1'
sealed.cs(2,21): (Location of symbol related to previous error)
sealed.cs(3,23): error CS0106: The modifier 'sealed' is not valid for this item
sealed.cs(4,32): error CS0238: 'S1.show()' cannot be sealed because it is not an override
*/