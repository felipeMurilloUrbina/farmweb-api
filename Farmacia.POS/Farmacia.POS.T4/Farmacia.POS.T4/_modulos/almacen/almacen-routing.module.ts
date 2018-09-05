import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AlmacenComponent } from './almacen.component';
import { NuevoAlmacenComponent } from './nuevo/nuevo.component';

const routes: Routes = [
  {path: '', component: AlmacenComponent},
  {path: 'nuevo', component: NuevoAlmacenComponent},
  {path: 'editar/:id', component: NuevoAlmacenComponent}
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class AlmacenRoutingModule { }
