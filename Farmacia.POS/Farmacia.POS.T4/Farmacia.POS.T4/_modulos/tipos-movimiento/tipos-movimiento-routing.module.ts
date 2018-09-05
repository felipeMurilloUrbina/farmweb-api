import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { TiposMovimientoComponent } from './tipos-movimiento.component';
import { NuevoTiposMovimientoComponent } from './nuevo/nuevo.component';

const routes: Routes = [
  {path: '', component: TiposMovimientoComponent},
  {path: 'nuevo', component: NuevoTiposMovimientoComponent},
  {path: 'editar/:id', component: NuevoTiposMovimientoComponent}
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class TiposMovimientoRoutingModule { }
