import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { LineaComponent } from './linea.component';
import { NuevoLineaComponent } from './nuevo/nuevo.component';

const routes: Routes = [
  {path: '', component: LineaComponent},
  {path: 'nuevo', component: NuevoLineaComponent},
  {path: 'editar/:id', component: NuevoLineaComponent}
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class LineaRoutingModule { }
