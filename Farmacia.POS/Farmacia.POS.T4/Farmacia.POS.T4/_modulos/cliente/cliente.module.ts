import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ClienteRoutingModule } from './cliente-routing.module';
import { ClienteComponent } from './cliente.component';
import { NuevoClienteComponent } from './nuevo/nuevo.component';

@NgModule({
  imports: [
    CommonModule,
    ClienteRoutingModule
  ],
  declarations: [
    ClienteComponent,
    NuevoClienteComponent,
  ]
})
export class ClienteModule { }


