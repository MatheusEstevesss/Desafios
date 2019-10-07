namespace TodoList
{
    public class TodoItem
    {
        public string Titulo;
        public string Nota;

        public TodoItem(string Titulo,string Nota){
            this.Titulo = Titulo;
            this.Nota = Nota;
        }

        public salvarArquivo (){
            StreamWriter salvar = new StreamWriter();

            salvar.WriteLine("isso ai");
            salvar.Close;
        }
    }
}