using System;

class Program{
  public static void Main(string[] args){
    Member member = new Member();

    Console.WriteLine(member["ali"]);
  }
}

public class Member{
  public string[] members = {"metin","ali","feyyaz"};

  public string this[int index]{
    get {
      if(index<0 || index>members.Length)
        return null;
      else
        return members[index];
    }
    set{
      if(!(index<0 || index>members.Length))
        members[index] = value;
    }
  }

  public int this[string query]{
    get{
      for(int i=0; i<members.Length; i++){
        if(query == members[i])
          return i;
      }
    return -1;
    }
  }
}
