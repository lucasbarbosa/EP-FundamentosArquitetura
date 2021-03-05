using ProjetoA;

namespace ProjetoB
{
    class TesteClasses
    {
        public TesteClasses()
        {
            var publica = new Publica();
            //var privada = new Privada(); // "Private" não funciona em assembly diferente.
            //var interna = new Interna(); // "Internal" não funciona por instância, apenas herança.
            //var abstrata = new Abstrata(); // "Abstract" não pode ser instanciada
        }
    }

    class TesteModificador1
    {
        public TesteModificador1()
        {
            var publica = new Publica();

            publica.TestePublico();
            //publica.TesteInternal(); // "Internal" não funciona em assembly diferente.
            //publica.TesteProtegidoInterno(); // "Protected Internal" não funciona em assembly diferente.
            //publica.TesteProtegido(); // "Protected" não funciona em assembly diferente.
            //publica.TestePrivadoProtegido(); // "Private Protected" não funciona em assembly diferente.
            //publica.TestePrivado(); // "Private" não funciona em assembly diferente.
        }
    }

    class TesteModificador2 : Publica
    {
        public TesteModificador2()
        {
            TestePublico();
            TesteProtegido();
            TesteProtegidoInterno();
            //TesteInternal(); // "Internal" não funciona em assembly diferente.
            //TestePrivadoProtegido(); // "Private Protected" não funciona em assembly diferente.
            //TestePrivado(); // "Private" não funciona em assembly diferente.
        }
    }
}