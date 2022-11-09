import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GReportListComponent } from './greport-list.component';

describe('GReportListComponent', () => {
  let component: GReportListComponent;
  let fixture: ComponentFixture<GReportListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ GReportListComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(GReportListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
