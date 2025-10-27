import './App.css';
import FirstComponent from './components/FirstComponent';
import TemplateExpression from './components/TemplateExpression';
import MyComponent from './components/MyComponent';
import Event from "./components/Event";
import Challenge from './components/Challenge';

function App() {
  return (
    <div className="App">
      <h1>Fundamentos do React - Aula01</h1>

      <FirstComponent />
      <TemplateExpression />
      <MyComponent />
      <Event />

      <h2>Desafio 01:</h2>
      <ul>
        Lista de Alunos:
        <li>Miguel</li>
        <li>Morandini</li>
      </ul>

      <Challenge />
    </div>
  );
}

export default App;
