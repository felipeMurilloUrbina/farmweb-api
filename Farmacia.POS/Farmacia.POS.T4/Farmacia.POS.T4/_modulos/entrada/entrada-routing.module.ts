import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { EntradaComponent } from './entrada.component';
import { NuevoEntradaComponent } from './nuevo/nuevo.component';

const routes: Routes = [
  {path: '', component: EntradaComponent},
  {path: 'nuevo', component: NuevoEntradaComponent},
  {path: 'editar/:id', component: NuevoEntradaComponent}
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class EntradaRoutingModule { }
