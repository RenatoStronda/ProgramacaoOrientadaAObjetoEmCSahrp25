namespace Classes{

    public class porta{
        private string cor;
        private bool estadoPorta;

            public string getCor(){
              return this.cor;
            }
                public void setCor(string cor){
                this.cor = cor;
            }
            public bool getEstadoPorta(){
                return this.estadoPorta;
            }
            public void abrirPorta(){
                    this.estadoPorta = true;
                }
                public void fecharPorta(){
                    this.estadoPorta = false;
                }
    }
}