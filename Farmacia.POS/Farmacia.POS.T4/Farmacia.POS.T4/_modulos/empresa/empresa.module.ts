import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { EmpresaRoutingModule } from './empresa-routing.module';
import { EmpresaComponent } from './empresa.component';
import { NuevoEmpresaComponent } from './nuevo/nuevo.component';

@NgModule({
  imports: [
    CommonModule,
    EmpresaRoutingModule
  ],
  declarations: [
    EmpresaComponent,
    NuevoEmpresaComponent,
  ]
})
export class EmpresaModule { }


