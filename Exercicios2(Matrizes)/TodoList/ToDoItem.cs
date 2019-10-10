namespace TodoList
{
    public class TodoItem
    {
        public string Titulo;
        public string Nota;

        public TodoItem(string Titulo,string Nota){ //nome do construtor deve ser igual ao nome da classe e não tem tipo de retorno (são as duas características do construtor) instancia uma classe voltado ao objeto (o construtor nos devolve o objeto)
            this.Titulo = Titulo;
            this.Nota = Nota;
        }
    }
}