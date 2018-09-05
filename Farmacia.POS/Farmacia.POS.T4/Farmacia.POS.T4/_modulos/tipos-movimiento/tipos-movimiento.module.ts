import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { TiposMovimientoRoutingModule } from './tipos-movimiento-routing.module';
import { TiposMovimientoComponent } from './tipos-movimiento.component';
import { NuevoTiposMovimientoComponent } from './nuevo/nuevo.component';

@NgModule({
  imports: [
    CommonModule,
    TiposMovimientoRoutingModule
  ],
  declarations: [
    TiposMovimientoComponent,
    NuevoTiposMovimientoComponent,
  ]
})
export class TiposMovimientoModule { }


