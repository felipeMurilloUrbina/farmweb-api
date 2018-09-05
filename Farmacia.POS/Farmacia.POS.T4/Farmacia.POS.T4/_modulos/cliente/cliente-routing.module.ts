import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ClienteComponent } from './cliente.component';
import { NuevoClienteComponent } from './nuevo/nuevo.component';

const routes: Routes = [
  {path: '', component: ClienteComponent},
  {path: 'nuevo', component: NuevoClienteComponent},
  {path: 'editar/:id', component: NuevoClienteComponent}
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ClienteRoutingModule { }
