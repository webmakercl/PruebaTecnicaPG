import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ClientesComponent } from './clientes/clientes.component';

const routes: Routes = [
  // Ruta por defecto que redirige a 'clientes'
  { path: '', redirectTo: 'clientes', pathMatch: 'full' },
  // Ruta para el componente de clientes
  { path: 'clientes', component: ClientesComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
