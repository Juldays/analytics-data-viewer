import React from "react";
import { Chart } from "primereact/components/chart/Chart";
import {
  adminAnalytics_getByDay,
  adminAnalytics_getByWeek,
  adminAnalytics_getByMonth,
  adminAnalytics_getBy6Months,
  adminAnalytics_getByYear
} from "./server";

class AdminAnalytics extends React.Component {
  state = {
    day: null,
    week: null,
    month: null,
    sixMonths: null,
    year: null
  };

  componentDidMount = () => {
    adminAnalytics_getByDay()
      .then(resp => {
        this.setState({
          day: resp.data.item
        });
      })
      .catch(err => {
        alert(err);
      });

    adminAnalytics_getByWeek()
      .then(resp => {
        this.setState({
          week: resp.data.item
        });
      })
      .catch(err => {
        alert(err);
      });

    adminAnalytics_getByMonth()
      .then(resp => {
        this.setState({
          month: resp.data.item
        });
      })
      .catch(err => {
        alert(err);
      });

    adminAnalytics_getBy6Months()
      .then(resp => {
        this.setState({
          sixMonths: resp.data.item
        });
      })
      .catch(err => {
        alert(err);
      });

    adminAnalytics_getByYear().then(resp => {
      this.setState({
        year: resp.data.item
      });
    });
  };

  render() {
    var day = this.state.day;
    var week = this.state.week;
    var month = this.state.month;
    var sixMonths = this.state.sixMonths;
    var year = this.state.year;

    var data = {
      labels: [
        "Past 24 Hours",
        "Past 7 Days",
        "Past 31 Days",
        "Past 6 months",
        "Past Year"
      ],
      datasets: []
    };

    let nextColor = 0;
    const colors = [
      "#8CC152",
      "#E9573F",
      "#37BC9B",
      "#F6BB42",
      "#00B1E1",
      "#906094",
      "#7789D1",
      "#63D3E9",
      "#AF86B9"
    ];

    function getColor() {
      return colors[nextColor++ % colors.length];
    }

    for (var key in day) {
      data.datasets.push({
        label: key,
        fill: false,
        borderColor: getColor(),
        data: [day[key].length]
      });
    }

    for (var index = 0; index < data.datasets.length; index++) {
      for (var key in week) {
        if (key === data.datasets[index].label) {
          data.datasets[index].data.push(week[key].length);
        }
      }
    }

    for (var index = 0; index < data.datasets.length; index++) {
      for (var key in month) {
        if (key === data.datasets[index].label) {
          data.datasets[index].data.push(month[key].length);
        }
      }
    }

    for (var index = 0; index < data.datasets.length; index++) {
      for (var key in sixMonths) {
        if (key === data.datasets[index].label) {
          data.datasets[index].data.push(sixMonths[key].length);
        }
      }
    }

    for (var index = 0; index < data.datasets.length; index++) {
      for (var key in year) {
        if (key === data.datasets[index].label) {
          data.datasets[index].data.push(year[key].length);
        }
      }
    }

    return (
      <div>
        <Chart type="line" data={data} />
      </div>
    );
  }
}

export default AdminAnalytics;
