import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { GruposRoutingModule } from './grupos-routing.module';
import { GruposComponent } from './grupos.component';
import { NuevoGruposComponent } from './nuevo/nuevo.component';

@NgModule({
  imports: [
    CommonModule,
    GruposRoutingModule
  ],
  declarations: [
    GruposComponent,
    NuevoGruposComponent,
  ]
})
export class GruposModule { }


