import * as React from 'react';
import { RouteComponentProps } from 'react-router';
import 'isomorphic-fetch';

interface OrderPanelState {
    orders: Order[];
    loading: boolean;
}

export class OrderPanel extends React.Component<RouteComponentProps<{}>, OrderPanelState> {
    constructor() {
        super();
        this.state = { orders: [], loading: true };

        fetch('api/Orders/')
            .then(response => response.json() as Promise<Order[]>)
            .then(data => {
                this.setState({ orders: data, loading: false });
            });
    }

    public render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : OrderPanel.renderForecastsTable(this.state.orders);

        return <div>
            <h1>Order List</h1>
            <p>Search all Orders in database.</p>
            { contents }
        </div>;
    }

    private static renderForecastsTable(orders: Order[]) {
        return <table className='table'>
            <thead>
                <tr>
                    <th>Id</th>
                    <th>Customer</th>
                    <th>Ordered Date</th>
                    <th>Details</th>
                </tr>
            </thead>
            <tbody>
            {orders.map(order =>
                <tr key={ order.id }>
                    <td>{ order.id }</td>
                    <td>{ order.customer }</td>
                    <td>{ order.orderDate }</td>
                    <td> click here </td>
                </tr>
            )}
            </tbody>
        </table>;
    }
}

interface Order {
    id: number;
    customer: string;
    orderDate: string;
}
