import * as React from 'react';
import { RouteComponentProps } from 'react-router';

export class OrderForm extends React.Component<RouteComponentProps<{}>, {}> {

    public render() {
        return <form onSubmit={ e => this.handleSubmit(e) }>
            <h1>New Order</h1>
            <div className="row">
              <div className="col-sm-6">
                <div className="form-group">
                  <label htmlFor="order-customer">Customer</label>
                  <input type="text" className="form-control" id="order-customer" name="customer" placeholder="Customer" />
                </div>
              </div>
              <div className="col-sm-6">
                <div className="form-group">
                  <label htmlFor="order-phone">Phone Number</label>
                  <input type="number" className="form-control" id="order-phone" name="phone" placeholder="Phone Number" />
                </div>
              </div>
            </div>
            <div className="col-sm-12 text-center">
              <button type="submit" className="btn btn-success">Submit</button>
            </div>
          </form>;
    }

    private handleSubmit(event: any) : void {
      event.preventDefault();

      const data = new FormData(event.target);
      
      //data.set('customer', 'test');
      //data.set('phone', '123');

      fetch('/api/orders/new', {
        method: 'POST',
        body: data,
      });

    }
}
