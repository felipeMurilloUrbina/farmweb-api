import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { LineaRoutingModule } from './linea-routing.module';
import { LineaComponent } from './linea.component';
import { NuevoLineaComponent } from './nuevo/nuevo.component';

@NgModule({
  imports: [
    CommonModule,
    LineaRoutingModule
  ],
  declarations: [
    LineaComponent,
    NuevoLineaComponent,
  ]
})
export class LineaModule { }


