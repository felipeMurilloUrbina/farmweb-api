import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ProductoRoutingModule } from './producto-routing.module';
import { ProductoComponent } from './producto.component';
import { NuevoProductoComponent } from './nuevo/nuevo.component';

@NgModule({
  imports: [
    CommonModule,
    ProductoRoutingModule
  ],
  declarations: [
    ProductoComponent,
    NuevoProductoComponent,
  ]
})
export class ProductoModule { }


