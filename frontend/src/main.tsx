import React from 'react';
import ReactDOM from 'react-dom/client';
import App from './App';

// PrimeReact Imports
import "primereact/resources/themes/lara-light-cyan/theme.css"; // Theme
import "primereact/resources/primereact.min.css";               // Core CSS
import "primeicons/primeicons.css";                             // Icons
import "primeflex/primeflex.css";                               // Grid/Utilities

ReactDOM.createRoot(document.getElementById('root')!).render(
  <React.StrictMode>
    <App />
  </React.StrictMode>,
);