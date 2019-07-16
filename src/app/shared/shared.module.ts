import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { FlexLayoutModule } from '@angular/flex-layout';
import { FormsModule } from '@angular/forms';
import { MatButtonModule } from '@angular/material/button';
import { MatIconModule } from '@angular/material/icon';
import { MatInputModule } from '@angular/material/input';
import { NgxMaterialTimepickerModule } from 'ngx-material-timepicker';
import { EntryDetailComponent } from 'src/app/shared/components/entry-detail/entry-detail.component';

import { EntryComponent } from './components/entry/entry.component';
import { HourPipe } from './services/hours.pipe';
import { TimePipe } from './services/time.pipe';
import { DayDetailComponent } from './components/day-detail/day-detail.component';

@NgModule({
  imports: [
    CommonModule,
    HttpClientModule,
    FormsModule,
    MatButtonModule,
    MatIconModule,
    MatInputModule,
    FlexLayoutModule,
    NgxMaterialTimepickerModule
  ],
  declarations: [EntryComponent, EntryDetailComponent, HourPipe, TimePipe, DayDetailComponent],
  exports: [EntryComponent, EntryDetailComponent, DayDetailComponent]
})
export class SharedModule {}
