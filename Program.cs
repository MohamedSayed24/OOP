using OOPC_;
using System.Drawing;

namespace OOPAssignment04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region What is the primary purpose of an interface in C#?

            //a) To provide a way to implement multiple inheritance
            #endregion

            #region Which of the following is NOT a valid access modifier for interface members in C#?

            //a) private
            #endregion

            #region Can an interface contain fields in C#?

            //b) No
            #endregion

            #region In C#, can an interface inherit from another interface?

            //b) Yes, interfaces can inherit from multiple interfaces
            #endregion

            #region Which keyword is used to implement an interface in a class in C#?

            //a) implements
            #endregion

            #region Can an interface contain static methods in C#?

            //b) No
            #endregion

            #region In C#, can an interface have explicit access modifiers for its members?

            // a) Yes, for all members
            #endregion

            #region What is the purpose of an explicit interface implementation in C#?

            //a) To hide the interface members from outside access
            #endregion

            #region In C#, can an interface have a constructor?

            //b) No, interfaces cannot have constructors
            #endregion

            #region How can a C# class implement multiple interfaces?

            //c) By separating interface names with commas
            #endregion

            //=========================== PART 2 ===========================

            #region Question 01:
            // Define an interface named IShape with a property Area and a method
            //DisplayShapeInfo.Create two interfaces, ICircle and IRectangle, that inherit from
            // IShape.Implement these interfaces in classes Circle and Rectangle. Test your
            //implementation by creating instances of both classes and displaying their shape
            //information.

            RectangleShape rectangle = new RectangleShape
            {
                Height = 10,
                Width = 20
            };
            rectangle.DisplayShapeInfo();
            #endregion
        }
    }
}
