import React from 'react';
import ReactDOM from 'react-dom';
import { Route, BrowserRouter as Router,Redirect, Switch} from 'react-router-dom';
// import { parseJwt, usuarioAutenticado } from './services/auth.js';
// (Colocar Redirect dps do router)

import Home from './pages/Home/Home'
// import Login from './pages/Login/Login.jsx';
import NotFound from './pages/NotFound/notFound.js';
// import Cadastrar from './pages/Cadastrar/Cadastrar.jsx';
// import Permissao from './pages/Permissao/permissao.js';
// import ListarAdm from './pages/ListarAdm/ListarAdm.jsx';
// import ListarPaciente from './pages/ListarPaciente/ListarPaciente.jsx';
// import ListarMedico from './pages/ListarMedico/ListarMedico.jsx';

import reportWebVitals from './reportWebVitals';

// const PermissaoAdm = ({ component: Component }) => (
//   <Route
//     render={(props) =>
//       usuarioAutenticado() && parseJwt().role === '2' ? (
//         // operador spread
//         <Component {...props} />
//       ) : (
//         <Redirect to="login" />
//       )
//     }
//   />
// );
// const PermissaoAdmC = ({ component: Component }) => (
//   <Route
//     render={(props) =>
//       usuarioAutenticado() && parseJwt().role === '2' ? (
//         // operador spread
//         <Component {...props} />
//       ) : (
//         <Redirect to="permissao" />
//       )
//     }
//   />
// );

// const PermissaoPaciente = ({ component: Component }) => (
//   <Route
//     render={(props) =>
//       usuarioAutenticado() && parseJwt().role === '1' ? (
//         // operador spread
//         <Component {...props} />
//       ) : (
//         <Redirect to="login" />
//       )
//     }
//   />
// );

// const PermissaoMedico = ({ component: Component }) => (
//   <Route
//     render={(props) =>
//       usuarioAutenticado() && parseJwt().role === '3' ? (
//         // operador spread
//         <Component {...props} />
//       ) : (
//         <Redirect to="login" />
//       )
//     }w
//   />
// );


const routing = (
  <Router>
    <div>
      <Switch>
        <Route exact path="/" component={Home} /> {/* Home */}
        <Route path="/login" component={Login} /> {/* Login */}
        <Route path="/notFound" component={NotFound} /> {/* Not Found */}
        <Redirect to="/notFound" /> {/* Redireciona para Not Found caso não encontre nenhuma rota */}
      </Switch>
    </div>
  </Router>
);

ReactDOM.render(
  routing,
  document.getElementById('root')
);

reportWebVitals();