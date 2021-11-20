import { Component, OnInit, ViewChild } from '@angular/core';
import { data } from 'jquery';
import { VehicleService } from '../../services/Vehicle.service';

@Component({
  selector: 'app-vehicles',
  templateUrl: './vehicles.component.html',
  styleUrls: ['./vehicles.component.scss']
})
export class VehiclesComponent implements OnInit {

  isLoading: boolean = true
  FilteredVehicles = []

  constructor(private VehicleService: VehicleService) { }

  ngOnInit(): void {
    this.VehicleService.GetAllVehicles().subscribe(res => {
      if (res.succeeded) {

        this.FilteredVehicles = res.data;
        console.log(this.FilteredVehicles)
      }
    }, error => {
      this.isLoading = false
    });
  }

}
