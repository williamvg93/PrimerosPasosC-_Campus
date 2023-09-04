internal class Program
{
    private static void Main(string[] args)
    {
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
        } else
        {
            Console.WriteLine($"{valNum2} es mayor que ${valNum1}");
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
        decimal value = 123.456m; 
        Console.WriteLine(value.ToString("C2"));
    }
}