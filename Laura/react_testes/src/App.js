import './App.css';
import Condicional from './components/Condicional';
import Evento from './components/Evento';
import Form from './components/Form';
//mport List from './components/List';


//  const meusItens = ['primeiro','segundo','terceito']
function App() {
  


  const unimarImg2 = 'https://ead.unimar.br/wp-content/themes/ead-22/images/logo.svg'
  return (

  <div className="App">
    <div className="loginContainer">
      <div className='HeaderContainer'>
        <a href="/App.js"><img src={unimarImg2} alt="LOGO UNIMAR"/></a>
      </div>
      <div className="conteudoContainer">
        <Form/>
        <Condicional/>
        <Evento/>
      </div>
    </div>

  </div>

  );
}

export default App;
