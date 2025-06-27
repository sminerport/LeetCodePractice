namespace Problems;

/// <summary>
/// Provides functionality to calculate the moving average of a stream of integers within a fixed-size sliding window.
/// </summary>
/// <remarks>The <see cref="P0346_Moving_Average_from_Data_Stream.MovingAverage_Array_List"/> class maintains a sliding
/// window of the most recent values added to it,  constrained by a specified window size. As new values are added,
/// older values are removed from the calculation once the window size is exceeded. This class is useful for scenarios
/// where a rolling average of recent data points is required, such as in real-time analytics or signal
/// processing.</remarks>
public class P0346_Moving_Average_from_Data_Stream
{
    /// <summary>
    /// Represents a moving average calculator that maintains a fixed-size sliding window of values.
    /// </summary>
    /// <remarks>The <see cref="MovingAverage_Array_List"/> class calculates the average of the most recent values added
    /// to it, constrained by a specified window size. As new values are added, older values are removed from the
    /// calculation once the window size is exceeded.</remarks>
    public class MovingAverage_Array_List
    {
        private readonly Queue<int> _window = new Queue<int>();
        private readonly int _size;
        private int _sum = 0;

        public MovingAverage_Array_List(int size)
        {
            _size = size;
        }

        public double Next(int val)
        {
            // Add new value
            _window.Enqueue(val);
            _sum += val;

            // If we've grown past the window size, remove the oldest value
            if (_window.Count > _size)
            {
                _sum -= _window.Dequeue();
            }

            // Compute and return the average
            return (double)_sum / _window.Count;
        }
    }

    /// <summary>
    /// Represents a moving average calculator that maintains a sliding window of a fixed size.
    /// </summary>
    /// <remarks>This class calculates the moving average of a sequence of integers using a double-ended queue
    /// (deque) to efficiently manage the sliding window. The size of the window is fixed and specified during
    /// initialization. As new values are added, older values are removed from the window when the size limit is
    /// exceeded.</remarks>
    public class MovingAverage_Double_Ended_Queue
    {
        private readonly int _size;
        private readonly LinkedList<int> _deque = new LinkedList<int>();
        private int _windowSum = 0, _count = 0;

        public MovingAverage_Double_Ended_Queue(int size)
        {
            _size = size;
        }

        public double Next(int val)
        {
            _count++;

            // Add new value to the deque
            _deque.AddLast(val);

            // If we've exceeded the window size, remove the oldest value
            if (_count > _size && _deque.First != null)
            {
                _windowSum -= _deque.First.Value;
                _deque.RemoveFirst();
            }

            // Add the new value to the sum
            _windowSum += val;

            // Calculate and return the average
            return (double)_windowSum / Math.Min(_count, _size);
        }
    }

    /// <summary>
    /// Represents a circular buffer for calculating a moving average over a fixed-size window of integers.
    /// </summary>
    /// <remarks>This class maintains a fixed-size buffer of the most recent integers and calculates the
    /// moving average as new values are added. The buffer automatically discards the oldest value when the buffer is
    /// full.</remarks>
    public class MovingAverage_Circular_Buffer
    {
        private readonly int[] _queue;
        private int _count = 0, _head = 0, _windowSum = 0, _size;

        public MovingAverage_Circular_Buffer(int size)
        {
            _size = size;
            _queue = new int[size];
        }

        public double Next(int val)
        {
            _count++;

            // Compute the index for the element that will fall out of the window
            int tail = (_head + 1) % _size;

            // update running sum: remove the old tail, add the new value
            _windowSum = _windowSum - _queue[tail] + val;

            // advance head and store the new value there
            _head = tail;
            _queue[_head] = val;

            // denominator is min(size, count) for the initial ramp-up
            int denominator = Math.Min(_count, _size);
            // Calculate and return the average
            return (double)_windowSum / denominator;
        }
    }