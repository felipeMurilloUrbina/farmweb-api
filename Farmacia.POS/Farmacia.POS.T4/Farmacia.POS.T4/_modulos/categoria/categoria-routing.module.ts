import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { CategoriaComponent } from './categoria.component';
import { NuevoCategoriaComponent } from './nuevo/nuevo.component';

const routes: Routes = [
  {path: '', component: CategoriaComponent},
  {path: 'nuevo', component: NuevoCategoriaComponent},
  {path: 'editar/:id', component: NuevoCategoriaComponent}
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class CategoriaRoutingModule { }
