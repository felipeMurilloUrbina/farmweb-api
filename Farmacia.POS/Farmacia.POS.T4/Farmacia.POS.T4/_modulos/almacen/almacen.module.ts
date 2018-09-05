 

import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { AlmacenRoutingModule } from './almacen-routing.module';
import { AlmacenComponent } from './almacen.component';
import { NuevoAlmacenComponent } from './nuevo/nuevo.component';

@NgModule({
  imports: [
    CommonModule,
    AlmacenRoutingModule
  ],
  declarations: [
    AlmacenComponent,
    NuevoAlmacenComponent,
  ]
})
export class AlmacenModule { }


