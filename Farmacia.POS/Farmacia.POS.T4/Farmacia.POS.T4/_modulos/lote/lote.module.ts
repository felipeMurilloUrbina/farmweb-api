import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { LoteRoutingModule } from './lote-routing.module';
import { LoteComponent } from './lote.component';
import { NuevoLoteComponent } from './nuevo/nuevo.component';

@NgModule({
  imports: [
    CommonModule,
    LoteRoutingModule
  ],
  declarations: [
    LoteComponent,
    NuevoLoteComponent,
  ]
})
export class LoteModule { }


