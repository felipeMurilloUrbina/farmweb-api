import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { EmpresaComponent } from './empresa.component';
import { NuevoEmpresaComponent } from './nuevo/nuevo.component';

const routes: Routes = [
  {path: '', component: EmpresaComponent},
  {path: 'nuevo', component: NuevoEmpresaComponent},
  {path: 'editar/:id', component: NuevoEmpresaComponent}
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class EmpresaRoutingModule { }
