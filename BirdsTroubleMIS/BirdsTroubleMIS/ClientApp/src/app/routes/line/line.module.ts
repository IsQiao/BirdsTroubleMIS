import { NgModule } from '@angular/core';
import { SharedModule } from '@shared';
import { LineRoutingModule } from './line-routing.module';
import { LineCurdViewComponent } from './curd/view/view.component';

const COMPONENTS = [
  ];
const COMPONENTS_NOROUNT = [
  LineCurdViewComponent];

@NgModule({
  imports: [
    SharedModule,
    LineRoutingModule
  ],
  declarations: [
    ...COMPONENTS,
    ...COMPONENTS_NOROUNT
  ],
  entryComponents: COMPONENTS_NOROUNT
})
export class LineModule { }
