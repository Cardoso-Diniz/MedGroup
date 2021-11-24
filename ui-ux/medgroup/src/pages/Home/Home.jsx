import '../../assets/css/home.css'
import '../../assets/css/footer.css'
import Header from '../../components/header/header';

import { Component } from "react";

export default class Home extends Component {

    render() {
      return (
        <div>
          <Header Login="Login" Props={this.props} />
  
          <main className="mainhome">
            <div className="corHome">
              <div className="container">
                <h1 className="h1_home">O cuidado completo com a sua saúde<span id="ponto_blue">.</span></h1>
                <p className="texto_sobre_nos">Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.
                </p>
              </div>
            </div>
          </main>
  
          <footer>
            <div className="container container_footer">
              <span className="span_footer">
              Clínica MedGroup - Todos os direitos reservados 2021.
              </span>
            </div>
          </footer>
        </div>
      )  
    }
  }