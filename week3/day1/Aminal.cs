using System;
using System.Collections.Generic;
using System.Text;

namespace Animal
{
  abstract  class Aminal
  {
      protected string name;
      protected int age;
      protected string gender;
      public abstract void Eat();
      public abstract string Size();
      public abstract void Greet();
      public abstract void WantChild();

  }
}
