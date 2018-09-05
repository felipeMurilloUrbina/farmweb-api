import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { LoteComponent } from './lote.component';
import { NuevoLoteComponent } from './nuevo/nuevo.component';

const routes: Routes = [
  {path: '', component: LoteComponent},
  {path: 'nuevo', component: NuevoLoteComponent},
  {path: 'editar/:id', component: NuevoLoteComponent}
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class LoteRoutingModule { }
