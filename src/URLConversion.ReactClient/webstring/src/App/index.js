import './App.css';
import AppLayout from './AppLayout'
import { AppProvider } from './AppProvider';
import AppBar from './AppBar';
import Content from '../Shared/Content';
import Home from '../Home'


function App() {
  return (
    <AppLayout>
      <AppProvider>
        <AppBar/>
        <Content>
          <Home/>
        </Content>
      </AppProvider>
    </AppLayout>
  );
}

export default App;
