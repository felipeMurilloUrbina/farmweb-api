import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { EntradaRoutingModule } from './entrada-routing.module';
import { EntradaComponent } from './entrada.component';
import { NuevoEntradaComponent } from './nuevo/nuevo.component';

@NgModule({
  imports: [
    CommonModule,
    EntradaRoutingModule
  ],
  declarations: [
    EntradaComponent,
    NuevoEntradaComponent,
  ]
})
export class EntradaModule { }


