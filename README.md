En alguna ocasión trabajando en una aplicación tuve la necesidad de convertir de números a texto (1 -> uno, 2 -> dos), lo primero que pensé fue en generar el algoritmo, pero después decidí realizar una búsqueda y me encontré con el proyecto **Number 2 Letters** así que lo implemente ya que la conversión era bastante buena y salvo algunos números como el 100 no tenía errores, en el siguiente código podrán ver como solo es necesario agregar una cultura con el lenguaje que deseamos convertir y el formato "**L**"

```language-csharp
        public static void Main(string[] args)
        {
            int i = 10;

            Microsoft.International.FormatCultureInfo cultureInfo = new FormatCultureInfo("es-ES");

            Console.WriteLine(string.Format(cultureInfo,"{0:L}",i));
            Console.ReadLine();
        }
```

Bastante fácil ¿No?.

Los lenguajes soportados por este proyecto son los siguientes:

 * fr-FR - Frances (Francia)
 * fr-BE - Frances (Bélgica)
 * fr-CH - Frances (Suiza)
 * es-ES - Español (España)
 * en-US - Inglés (USA)
 * de-DE - Alemán (Alemania)

El código de ejemplo lo puedes descargar de [github](https://github.com/Satur01/NumbersToWords/blob/master/NumberToWords).
El proyecto está en [codeplex](https://n2l.codeplex.com/wikipage?title=How%20to%20implement%20the%20library) y puedes visitarlo, mientras tanto me despido ¡saludos!
