import './App.css';
import Weather from './Components/Weather';

export default function App() {
      
    return (
        <div>
            <h1 id="tableLabel">Weather forecast</h1>
            <p>This component demonstrates fetching data from the server.</p>
            <Weather />
        </div>
    );
};