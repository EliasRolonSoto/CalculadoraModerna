namespace TestQueue
{
    public class UnitTest1
    {
        [Fact]
        public void DebeAgregarElementoACola()
        {
            Queue<int> q = new Queue<int>();
            var valor = 1;


            q.Enqueue(valor);


            Assert.Equal(1, q.Count);

            Assert.Equal(valor, q.Peek());
        }


        [Fact]
        public void DebeEliminarDeCola()
        {
            Queue<int> q = new Queue<int>();


            int valor = 10;
            q.Enqueue(valor);

          
            var elementoEliminado = q.Dequeue();

            Assert.Equal(10, elementoEliminado);

            Assert.Equal(0, q.Count());
        }


        [Fact]
        public void DebeAgregarListaEnCola()
        {
            Queue<int> q = new Queue<int>();


            for (int i =0; i < 10; i++)
            {
                q.Enqueue(i);
            }

            Assert.Equal(10, q.Count());
            
        }
    }
}