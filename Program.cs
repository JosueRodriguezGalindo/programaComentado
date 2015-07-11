//La línea número 1 "using System", contiene varias clases fundamentales para un óptimo funcionamiento de nuestro código
//además que para fines practicos la usaremos para mandar a imprimir datos a pantalla.
using System;

//La línea número 2 "using System.IO", indica que usaremos input y outpu, las cuales nos servirán para el flujo de datos, así como para leer y escribir en archivos
using System.IO;

//En la siguiente línea estamos declarando nuestra clase, seguido de su nombre. Esto es importante, es escencial en el código, no funcionaría sin ello.
class Demo

 //abrimos la llave donde inicia nuestra clase, dentro de ella irá todo el código o secciones del mismo.
{

    //Declaramos un arreglo de tipo Alumno (Alumno es una estructura) con una capacidad para almacenar 10 elementos que cada uno de ellos será un alumno
    //el cual contendrá dentro de su estructura: Nombre, apellidoPaterno, apellidoMaterno, edad  y contendrá un
    //objeto carrera, el cuál obtendrá su valor desde otra estructura.
    static Alumno[] alumno = new Alumno[10];

    //Declaramos un arreglo de tipo Carrea (Carrera es una estructura) con una capacidad de albergar 6 elementos, al ser una estructura, se le puede
    //agregar más de una información, en este caso, Carrera contiene: Id, Nombre
    static Carrera[] carrera = new Carrera[6];

    //Creamos una variable de tipo string y además será estática (con esto definimos que no cambia), está variable la usaremos para poner en ella la ruta en la cual guardaremos nuestros resultados
    //que obtendremos al usar StreamWritter.
    static string fileName = "Definir ruta";
    
    //Declaramos una variable de tipo StreamWritter, llamada escribir. La usaremos para poder escribir en un archivo, debemos definirle una dirección
    //para eso se ha creado la variable fileName, en el paso anterior. Usaremos la ruta que venga en ella para escribir el resultado de nuestra operación.
    static StreamWriter escribir;
    
    //Vamos a declarar nuestra estructura que se llama Alumno, en la cual contendrá variables de tipo string, byte, y una variable de tipo carrera.
    struct Alumno

        //Las estructuras llevan llaves, ya que se también corresponden a métodos. La siguiente llave es de apertura.
    {
        //Declaramos una variable publica, sera visible en cualquier parte del código; será de tipo string y la llamaremos Nombre, contendrá el nombre del usuario,
        //tendra declarado los metodos get y set, donde set nos sirve para darle valores, y get para obtener los valores de dicha variable.
        public string Nombre { get; set; }

        //Declaramos una variable de tipo string llamada ApellidoPaterno y que será publica. La usamos para asignarle un apellido paterno al usuario.
        //tendra declarado los metodos get y set, donde set nos sirve para darle valores, y get para obtener los valores de dicha variable.
        public string ApellidoPaterno { get; set; }

        //Declaramos una variable de tipo string llamada ApellidoMaterno y que será publica. La usamos para asignarle el apellido materno al usuario.,
        //tendra declarado los metodos get y set, donde set nos sirve para darle valores, y get para obtener los valores de dicha variable.
        public string ApellidoMaterno { get; set; }

        //Declaramos una variable de tipo byte llamada Edad y que será publica. Será para asignar una edad a cada alumno,
        //tendra declarado los metodos get y set, donde set nos sirve para darle valores, y get para obtener los valores de dicha variable.
        public byte Edad { get; set; }

        //Declaramos una variable de tipo Carrera llamada Carrera y que será publica. Esto con el fin de poder relacionar dos o más estructuras entre sí,
        //tendra declarado los metodos get y set, donde set nos sirve para darle valores, y get para obtener los valores de dicha variable.
        public Carrera Carrera { get; set; }

        //La siguiente llave es de clausura, con esto cerramos la estructura Alumno.
    }

    //Vamos a declarar nuestra estructura que se llama Carrera, en la cual contendrá variables de tipo int y string.
  struct Carrera

      //Llave de apertura de nuestra estrucutra declarada anteriormente.
    {

      //Declaramos una variable de tipo int, llamada Id, con el fin de poder de darle un identificador a cada carrera
      // posee get y set, los usamos para obtener y dar valores, respectivamente.
        public int Id { get; set; }

        //Declaramos una variable de tipo string, llamada Nombre para identificar el nombre de cada carrera
        // posee get y set, los usamos para obtener y dar valores, respectivamente.
        public string Nombre { get; set; }

      //La siguiente llave es una llave de clausura, y es usada para definir que aquí es el cierre de nuestra estructura de Carrera.
    }

    //A continuación declaramos un método estático, lo declararemos de tipo arreglo de nuestra estructura Carrera, el arreglo de tipo carrera se declaró anteriomente
    // seguido de la firma del método pondremos el nombre, de acuerdo a la sintaxis correcta para nombrar métodos.
    static Carrera[] LoadDataCarreras()

        //Llave de apertura de nuestro método, esto indica que tendremos un bloque, en el cual irá una parte del código que queremos separar del resto.
    {

        //Declaramos un arreglo de tipo string, llamado carreras, los cuales contendrá cada uno de los nombres de las carreras.
        string[] carreras = {
             //Nombre de una carrera.
			"Licenciatura en Administración y Gestión de PYMES",
            //Nombre de una carrera. 
			"Ingeniería en Animación y Efectos Visuales",
            //Nombre de una carrera. 
            "Ingeniería en Energía",
            //Nombre de una carrera.
			"Ingeniería Mecatrónica",
            //Nombre de una carrera.
			"Ingeniería en Tecnologías de Manufactura",
            //Nombre de una carrera.
			"Ingeniería en Tecnologías de la Información"

            //Cerramos nuestro arreglo
		};

        //El siguiente ciclo es par añadir cada una de las carreras que declaramos en nuestro arreglo llamado carreras
        //inicializamos una variable en 0, lo condicionamos a que siempre sea menor al tamaño que tenga el arreglo carrera, además que vaya en aumento de +1
        for (int i = 0; i < carrera.Length; i++)

            //llave de apertura de nuestro ciclo for.
        {
            //Creamos un objeto N de tipo carrera, cada vez que se repita el ciclo se creará uno, hasta que el ciclo concluya.
            carrera[i] = new Carrera();

            //Añadimos un identifcador al elemento que se encuentra en nuestra estructura Carrera, llamado Id, de acuerdo al valor que tenga i.
            carrera[i].Id = i + 1;

            //Añadimos un nombre de una de las carreras que de positamos en carreras a la variable Nombre de nuestra estructura Carrera.
            //De acuerdo al valor de i, será el elemento que agregará al atributo Nombre, de la estructura Carrera.
            carrera[i].Nombre = carreras[i];

            //Llave de clausura del ciclo for. A pesar de que es una llave de clausura, no saldrá del ciclo hasta que cumpla la condición.
        }

        //Al momento de declar nuestro método de algún tipo, en este caso de Arreglo, necesitamos regresar un valor, el cual será nuestro arreglo carrea.
        return carrera;

        //Con esta llave declaramos el fin de nuestro método .
    }

    //Declaramos nuestro método principal, el cual nos sirve para la ejecución de nuestro código.
    static void Main()

        //Abrimos llave, indicando la apertura de nuestro método main.
    {

        //Declaramos el inicio de nuestra excepción, en dado caso de que ocurra un error al ejecutar el código nos arrojará un mensaje de error.
        //La parte principal es try, el cual en español se define como intentar, con esto queremos decir que realizará las instrucciones, si cae en  
        //algun error, el sistema arrojará una exepción.
        try

            //Llave de apertura de nuestra excepcion
        {

            //Nuestra variable escribir la instanciamos y le pasamos como parametro nuestra variable fileName, ésta última contiene la dirección de donde alojará el archivo 
            //de los resultados, al final ponemos true, esto con el fin de que cada vez que se ejecute el programa continue escribiendo en el archivo y no lo sustituya.
            //Si no tuviera true, cada vez que se ejecute el código se sustituirá 
            escribir = new StreamWriter(fileName, true);

             //declaramos un foreach, donde se declara una variable de tipo Carrera, el cual se encargará de recorrer nuestro arreglo definido en LoadDaraCarreras().
            foreach (Carrera c in LoadDataCarreras())

                //abrimos nuestro ciclo con la llave de apertura.
            {

                //La siguiente línea muestra como nuestra variable escribir, la cual pertenece a streamWritter, escribirá cada resultado obtenido en nuestro archivo.
                //Usamos string.Format para dar formato a nuestro texto de sálida, podemos tener varias formas de hacerlo, fecha, moneda, hora. Todo dependerá 
                //de nuestra configuración regional.
                escribir.WriteLine(string.Format("{0}. {1}.", c.Id, c.Nombre));

                //Cerramos nuestro ciclo foreach con una llave de clausura
            }
           
            //Debemos cerrar nuestro sistema de escritura, esto con el fin de que se queda esperando más información y no pueda escribir nada, esto lo hacemo al final de la parte
            //que queramos que escriba, si lo hacemos antes, no escribirá nada.
          escribir.Close();

            //Cerramos nuestro try con una llave de clausura.
        }

            //Con catch le estamos diciendo que atrape el error si no encuentra el archivo.
        catch (FileNotFoundException e)

            
        {

            //Mandamos un mensaje a pantalla para poder determinar el error resultante.
            Console.WriteLine("The file '{0}' is not found.", fileName);

            //Cerramos nuestro catch con llave de clausura
        }
           
    //Cerramos nuestro método principal, llamado Main, al cerrar el método Main, no ejecutara nada que esté fuera de él, al menos que sea invocado.
    }

    //Cerramos nuestra clase y también terminamos el código, si ponemos algo después de la llave de clausura nos marcará un error ya que no pertenece a algo.
}