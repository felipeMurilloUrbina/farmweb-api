import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { SucursalRoutingModule } from './sucursal-routing.module';
import { SucursalComponent } from './sucursal.component';
import { NuevoSucursalComponent } from './nuevo/nuevo.component';

@NgModule({
  imports: [
    CommonModule,
    SucursalRoutingModule
  ],
  declarations: [
    SucursalComponent,
    NuevoSucursalComponent,
  ]
})
export class SucursalModule { }


