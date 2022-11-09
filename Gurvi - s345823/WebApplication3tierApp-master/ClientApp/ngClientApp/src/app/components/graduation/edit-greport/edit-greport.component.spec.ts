import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EditGReportComponent } from './edit-greport.component';

describe('EditGReportComponent', () => {
  let component: EditGReportComponent;
  let fixture: ComponentFixture<EditGReportComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EditGReportComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(EditGReportComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
