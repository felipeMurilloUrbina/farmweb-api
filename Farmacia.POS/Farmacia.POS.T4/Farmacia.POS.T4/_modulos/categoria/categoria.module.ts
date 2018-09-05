import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { CategoriaRoutingModule } from './categoria-routing.module';
import { CategoriaComponent } from './categoria.component';
import { NuevoCategoriaComponent } from './nuevo/nuevo.component';

@NgModule({
  imports: [
    CommonModule,
    CategoriaRoutingModule
  ],
  declarations: [
    CategoriaComponent,
    NuevoCategoriaComponent,
  ]
})
export class CategoriaModule { }


