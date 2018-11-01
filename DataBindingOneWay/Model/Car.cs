namespace DataBindingOneWay.Model
{
   public class Car
   {
       public int Id { get; set; }
       public string Name { get; set; }

       public Car(int id, string name)
       {
           Id = id;
           Name = name;
       }
       public override string ToString()
       {
           return $"ID:{Id}-Name:{Name}";
       }
   }
}
