import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { GruposComponent } from './grupos.component';
import { NuevoGruposComponent } from './nuevo/nuevo.component';

const routes: Routes = [
  {path: '', component: GruposComponent},
  {path: 'nuevo', component: NuevoGruposComponent},
  {path: 'editar/:id', component: NuevoGruposComponent}
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class GruposRoutingModule { }
