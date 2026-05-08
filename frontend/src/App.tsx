import { Button } from 'primereact/button';
import { Card } from 'primereact/card';

function App() {
  return (
    <div className="flex justify-content-center align-items-center h-screen">
      <Card title="Smart Home Hub" className="w-full md:w-25rem">
        <p className="m-0">Hello World</p>
        <Button label="View Devices" icon="pi pi-home" className="mt-3" />
      </Card>
    </div>
  );
}

export default App;