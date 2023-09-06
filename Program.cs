using System.Collections;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        String ? letter;
        int idx = 0;
        List<String> Subjects = new List<String>();
        Subjects.Add("math");
        Subjects.Add("english");
        Subjects.Add("biology");
/*         Console.WriteLine("Enter the Element Index: ");
        idx = Convert.ToInt16(Console.ReadLine());
        ListCount(Subjects);
        Console.WriteLine($"El elemento en el indice {idx} es: {GetElement(idx, Subjects)}");
        Subjects.Add(AddElement()); */
/*         Console.WriteLine("Enter the Element  to Search: ");
        if (CheckElement(Subjects, Console.ReadLine().ToLower())) {
            Console.WriteLine("If it Exists");
        } else {
            Console.WriteLine("If not Exists");
        } */
        Console.WriteLine("Enter the letter: ");
        letter = Console.ReadLine();
        Console.WriteLine($"Element in list: {SearchElement(Subjects, letter)}");


        /* int edad; */
        /* float precio = 23.0f; */
        /* Pedir Datos por consola */
        /* Console.WriteLine("Ingrese su edad: "); */

        /* try {
            edad = int.Parse(Console.ReadLine() ?? "0");
            edad = Convert.ToUInt16(Console.ReadLine() ?? "0");
            precio = float.Parse(Console.ReadLine() ?? "0");

        } catch (Exception ex) {
            Console.WriteLine(ex.Message.ToString());
            Console.WriteLine(ex.Message.ToString());

            Concatenar
            Console.WriteLine("Error: {0}", ex.Message.ToString());
        } */

        /* Console.WriteLine("Hello, World!"); */
        /* PRINT con salto de linea */
        /* Console.WriteLine("Buen día"); */
        /* PRINT sin salto de linea */
        /* Console.Write("Hello !!");
        Console.WriteLine("No hay salto");

        int valNum1 = 3;
        int valNum2 = 4;
        if (valNum1 > valNum2) 
        {
            Console.WriteLine($"{valNum1} es mayor que {valNum2}");
        {
            Console.WriteLine($"{valNum2} es mayor que ${valNum1}");
        } else
        } */

        /* int valNum3 = 3;
        switch (valNum3){
            case > 1:
                Console.WriteLine("El valor es 1");
                break;
            case > 1:
                Console.WriteLine("El valor es 2");
                break;
            default:
                Console.WriteLine("mensaje default");
                break;
        }
 */
        /* AND:  && evalua las 2 expresiones  --  & evalua solo 1 expresion en caso de ser FASLSA  */
        /* OR : || evalua las 2 expresiones  --  | evalua solo 1 expresion en caso de ser FASLSA  */
        /* Not:  ! */

        /* double d = 3D;
        d = 4d;
        d = 3.934_001;
        Console.WriteLine($"{d}");
        float f = 3_000.5f;
        f = 5.403f;
        Console.WriteLine($"{f}");
        decimal myMoney = 3_000.5m;
        myMoney = 400.75M;
        Console.WriteLine($"{myMoney}"); */

        /*bool valBool = true;
        Console.WriteLine(valBool ? "Verdadero" : "Falso");
        Console.WriteLine(false ? "Verdadero" : "Falso"); */

        /* Al colocar m al final del valor, le estamos diciendo a C# que esto va a ser un valor monetario */
/*         decimal value = 123.456m; 
        Console.WriteLine(value.ToString("C2")); */

/* 
        int[] numeros = {10,11,12,13,14,15};
        foreach (var item in numeros)
        {
            Console.WriteLine(item);
        }
        ArrayList nameList = new ArrayList();
        nameList.Add( "william" );
        nameList.Add( "Camilo" );
        nameList.Add( "Juan David");
        nameList.Add( "Edwin" );
        foreach (object name in nameList)
        {
            Console.WriteLine(name.ToString());            
        }

        ArrayList carniAnim = new ArrayList();
        ArrayList aquatAnim = new ArrayList();
        ArrayList allAnimals = new ArrayList();
        carniAnim.Add( "tiger" );
        carniAnim.Add( "lion" );
        carniAnim.Add( "dog" );
        carniAnim.Add( "cat" );
        aquatAnim.Add( "shark" );
        aquatAnim.Add( "fish" );
        aquatAnim.Add( "crab" );
        aquatAnim.Add( "turtle" );

        allAnimals.AddRange(carniAnim);
        allAnimals.AddRange(aquatAnim);
        foreach (object animal in allAnimals)
        {
            Console.WriteLine(animal.ToString());
        } */

        /* Eliminar Datos de un array */
        /* allAnimals.Clear(); */

        /* string ? word;
        ArrayList studySubjects = new ArrayList();
        studySubjects.Add( "math" );
        studySubjects.Add( "english" );
        studySubjects.Add( "chemistry" );
        studySubjects.Add( "biology" );
        studySubjects.Add( "history" );

        Console.WriteLine("Enter the subject to search: ");
        word = Console.ReadLine();
        Console.WriteLine(studySubjects.Contains(word) ? "The subject is available" : "The subject is not avalilable");
        Console.WriteLine(studySubjects.IndexOf(word)); */

        /* string ? subject;
        int idx;
        ArrayList subjectList = new ArrayList();

        subjectList.Add(" spanish ");
        subjectList.Add(" ethics ");
        subjectList.Add(" math ");
        subjectList.Add(" biology ");

        do
        {
            Console.WriteLine("Enter ther position where you want to save Data");
            idx = Convert.ToInt32(Console.ReadLine());
        } while (idx > subjectList.Count);

        Console.Write("Enter the Subject: ");
        subject = Console.ReadLine();
        subjectList.Insert(idx, subject);

        foreach (object subj in subjectList)
        {
            Console.WriteLine(subj.ToString());
        }
 */
        /* int[] numeros = {10,11,12,13,14,15};
        int[] numbers = {1,2,3,4};
        ArrayList numbersList = new ArrayList();
        numbersList.Add(numbers);
        numbersList.Insert(0, numbers); */
    

    }

    public static void ListCount(List<String> lista) {
        Console.WriteLine($"La cantidad de elementos que hay son: {lista.Count()}");
    }

    public static string GetElement(int idx,List<String> Lista) {
        return Lista[idx];
    }

    public static string AddElement() {
        string ? dato;
        Console.WriteLine("Enter the Elemento to Add: ");
        dato = Console.ReadLine();
        return dato;
    }

    public static bool CheckElement(List<String> Lista, string Element){
        /* Console.WriteLine("Enter the element to search"); */
        return Lista.Exists(l => l.ToLower().Equals(Element));
    }
    
    public static string SearchElement(List<String> Lista, string Letter){
        return Lista.Find(n => n.StartsWith(Letter ?? String.Empty));
    }

}
