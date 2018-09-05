import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { SucursalComponent } from './sucursal.component';
import { NuevoSucursalComponent } from './nuevo/nuevo.component';

const routes: Routes = [
  {path: '', component: SucursalComponent},
  {path: 'nuevo', component: NuevoSucursalComponent},
  {path: 'editar/:id', component: NuevoSucursalComponent}
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class SucursalRoutingModule { }
