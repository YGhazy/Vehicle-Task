import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AuthenticationService } from '../../services/authentication.service';
import { CustomerService } from '../../services/Customer.service';
import { Howl, Howler } from 'howler';

@Component({
  selector: 'app-customer',
  templateUrl: './customer.component.html',
  styleUrls: ['./customer.component.scss']
})
export class CustomerComponent implements OnInit {

  customer;
  pingTone
  isPing: boolean = false

  constructor(private authService: AuthenticationService, private router: Router, private customerService: CustomerService) { }


  ngOnInit(): void {

    if (!this.authService.isInRole("Customer"))
      this.router.navigate(['/vehicles']);


    this.pingTone = new Howl({
      src: ['./assets/notification-tone.mp3']
    });

    //get current customer
    this.customerService.GetCurrentCustomer().subscribe(res => {
      if (res.succeeded) {
        this.customer=res.data
        console.log(res.data)
      }
    }, error => {
      //this.isLoading = false
    });

    this.CustomerVehiclesPing()

    setTimeout(() => {
      this.CustomerVehiclesPing()
    }, 60000);
  }

  Logout() {
    this.authService.logout()
    this.router.navigate(['/auth']);
  }

  CustomerVehiclesPing() {
    this.isPing=true
    this.customerService.CustomerVehiclesPing().subscribe(res => {
      if (res.succeeded) {
        this.isPing = false

        this.pingTone.play();
        console.log(res.data)
      }
    }, error => {
        this.isPing = false
    });
  }
}
